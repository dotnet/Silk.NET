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

[Guid("96C9621A-C143-4392-BEDD-4A7E9574C8FD")]
[NativeTypeName("struct IBrightnessOverride : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBrightnessOverride : IBrightnessOverride.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrightnessOverride));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBrightnessOverride, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBrightnessOverride, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrightnessOverride, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBrightnessOverride, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBrightnessOverride, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBrightnessOverride, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBrightnessOverride, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBrightnessOverride, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BrightnessLevel(double* level)
    {
        return ((delegate* unmanaged<IBrightnessOverride, double*, int>)((*lpVtbl)[8]))(
            this,
            level
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBrightnessLevel(
        double brightnessLevel,
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")]
            DisplayBrightnessOverrideOptions options
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverride,
                double,
                DisplayBrightnessOverrideOptions,
                int>)((*lpVtbl)[9])
        )(this, brightnessLevel, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetBrightnessScenario(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")]
            DisplayBrightnessScenario scenario,
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")]
            DisplayBrightnessOverrideOptions options
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverride,
                DisplayBrightnessScenario,
                DisplayBrightnessOverrideOptions,
                int>)((*lpVtbl)[10])
        )(this, scenario, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetLevelForScenario(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")]
            DisplayBrightnessScenario scenario,
        double* brightnessLevel
    )
    {
        return (
            (delegate* unmanaged<IBrightnessOverride, DisplayBrightnessScenario, double*, int>)(
                (*lpVtbl)[11]
            )
        )(this, scenario, brightnessLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StartOverride()
    {
        return ((delegate* unmanaged<IBrightnessOverride, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT StopOverride()
    {
        return ((delegate* unmanaged<IBrightnessOverride, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_IsSupportedChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverride,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_IsSupportedChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBrightnessOverride, EventRegistrationToken, int>)((*lpVtbl)[15])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_IsOverrideActiveChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverride,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBrightnessOverride, EventRegistrationToken, int>)((*lpVtbl)[17])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_BrightnessLevelChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBrightnessOverride,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[18])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_BrightnessLevelChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBrightnessOverride, EventRegistrationToken, int>)((*lpVtbl)[19])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_BrightnessLevel(double* level);

        [VtblIndex(9)]
        HRESULT SetBrightnessLevel(
            double brightnessLevel,
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")]
                DisplayBrightnessOverrideOptions options
        );

        [VtblIndex(10)]
        HRESULT SetBrightnessScenario(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")]
                DisplayBrightnessScenario scenario,
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions")]
                DisplayBrightnessOverrideOptions options
        );

        [VtblIndex(11)]
        HRESULT GetLevelForScenario(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessScenario")]
                DisplayBrightnessScenario scenario,
            double* brightnessLevel
        );

        [VtblIndex(12)]
        HRESULT StartOverride();

        [VtblIndex(13)]
        HRESULT StopOverride();

        [VtblIndex(14)]
        HRESULT add_IsSupportedChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(15)]
        HRESULT remove_IsSupportedChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_IsOverrideActiveChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(17)]
        HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_BrightnessLevelChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(19)]
        HRESULT remove_BrightnessLevelChanged(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOverrideActive;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_BrightnessLevel;

        [NativeTypeName(
            "HRESULT (DOUBLE, ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double,
            DisplayBrightnessOverrideOptions,
            int> SetBrightnessLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayBrightnessScenario, ABI::Windows::Graphics::Display::DisplayBrightnessOverrideOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DisplayBrightnessScenario,
            DisplayBrightnessOverrideOptions,
            int> SetBrightnessScenario;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayBrightnessScenario, DOUBLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DisplayBrightnessScenario,
            double*,
            int> GetLevelForScenario;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StartOverride;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopOverride;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_IsSupportedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_IsSupportedChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_IsOverrideActiveChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_IsOverrideActiveChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CBrightnessOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_BrightnessLevelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_BrightnessLevelChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBrightnessOverride"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBrightnessOverride(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBrightnessOverride"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBrightnessOverride(Silk.NET.WinRT.IInspectable value)
    {
        return new IBrightnessOverride(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBrightnessOverride"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBrightnessOverride"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBrightnessOverride value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBrightnessOverride"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBrightnessOverride(Silk.NET.Windows.IUnknown value)
    {
        return new IBrightnessOverride(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBrightnessOverride"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBrightnessOverride"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBrightnessOverride value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
