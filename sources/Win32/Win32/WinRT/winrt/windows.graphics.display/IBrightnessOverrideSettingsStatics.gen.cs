// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D487DC90-6F74-440B-B383-5FE96CF00B0F")]
[NativeTypeName("struct IBrightnessOverrideSettingsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBrightnessOverrideSettingsStatics
    : IBrightnessOverrideSettingsStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrightnessOverrideSettingsStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBrightnessOverrideSettingsStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBrightnessOverrideSettingsStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrightnessOverrideSettingsStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IBrightnessOverrideSettingsStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBrightnessOverrideSettingsStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBrightnessOverrideSettingsStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromLevel(
        double level,
        [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
            IBrightnessOverrideSettings* result
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverrideSettingsStatics,
                double,
                IBrightnessOverrideSettings*,
                int>)((*lpVtbl)[6])
        )(this, level, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNits(
        float nits,
        [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
            IBrightnessOverrideSettings* result
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverrideSettingsStatics,
                float,
                IBrightnessOverrideSettings*,
                int>)((*lpVtbl)[7])
        )(this, nits, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromDisplayBrightnessOverrideScenario(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideScenario")]
            DisplayBrightnessOverrideScenario overrideScenario,
        [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
            IBrightnessOverrideSettings* result
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverrideSettingsStatics,
                DisplayBrightnessOverrideScenario,
                IBrightnessOverrideSettings*,
                int>)((*lpVtbl)[8])
        )(this, overrideScenario, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromLevel(
            double level,
            [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
                IBrightnessOverrideSettings* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromNits(
            float nits,
            [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
                IBrightnessOverrideSettings* result
        );

        [VtblIndex(8)]
        HRESULT CreateFromDisplayBrightnessOverrideScenario(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideScenario")]
                DisplayBrightnessOverrideScenario overrideScenario,
            [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
                IBrightnessOverrideSettings* result
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
            "HRESULT (DOUBLE, ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double,
            IBrightnessOverrideSettings*,
            int> CreateFromLevel;

        [NativeTypeName(
            "HRESULT (FLOAT, ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float, IBrightnessOverrideSettings*, int> CreateFromNits;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayBrightnessOverrideScenario, ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DisplayBrightnessOverrideScenario,
            IBrightnessOverrideSettings*,
            int> CreateFromDisplayBrightnessOverrideScenario;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBrightnessOverrideSettingsStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBrightnessOverrideSettingsStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBrightnessOverrideSettingsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBrightnessOverrideSettingsStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBrightnessOverrideSettingsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBrightnessOverrideSettingsStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBrightnessOverrideSettingsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBrightnessOverrideSettingsStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBrightnessOverrideSettingsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBrightnessOverrideSettingsStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBrightnessOverrideSettingsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBrightnessOverrideSettingsStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBrightnessOverrideSettingsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBrightnessOverrideSettingsStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
