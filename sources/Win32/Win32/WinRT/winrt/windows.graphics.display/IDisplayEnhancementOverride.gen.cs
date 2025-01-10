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

[Guid("429594CF-D97A-4B02-A428-5C4292F7F522")]
[NativeTypeName("struct IDisplayEnhancementOverride : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayEnhancementOverride
    : IDisplayEnhancementOverride.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayEnhancementOverride));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ColorOverrideSettings(
        [NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings **")]
            IColorOverrideSettings* value
    )
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, IColorOverrideSettings*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ColorOverrideSettings(
        [NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings *")]
            IColorOverrideSettings value
    )
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, IColorOverrideSettings, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BrightnessOverrideSettings(
        [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
            IBrightnessOverrideSettings* value
    )
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, IBrightnessOverrideSettings*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BrightnessOverrideSettings(
        [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings *")]
            IBrightnessOverrideSettings value
    )
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, IBrightnessOverrideSettings, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CanOverride([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, byte*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCurrentDisplayEnhancementOverrideCapabilities(
        [NativeTypeName(
            "ABI::Windows::Graphics::Display::IDisplayEnhancementOverrideCapabilities **"
        )]
            IDisplayEnhancementOverrideCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayEnhancementOverride,
                IDisplayEnhancementOverrideCapabilities*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RequestOverride()
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT StopOverride()
    {
        return ((delegate* unmanaged<IDisplayEnhancementOverride, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_CanOverrideChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayEnhancementOverride,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_CanOverrideChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, EventRegistrationToken, int>)(
                (*lpVtbl)[16]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_IsOverrideActiveChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayEnhancementOverride,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, EventRegistrationToken, int>)(
                (*lpVtbl)[18]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_DisplayEnhancementOverrideCapabilitiesChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_Windows__CGraphics__CDisplay__CDisplayEnhancementOverrideCapabilitiesChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayEnhancementOverride,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[19])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_DisplayEnhancementOverrideCapabilitiesChanged(
        EventRegistrationToken token
    )
    {
        return (
            (delegate* unmanaged<IDisplayEnhancementOverride, EventRegistrationToken, int>)(
                (*lpVtbl)[20]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ColorOverrideSettings(
            [NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings **")]
                IColorOverrideSettings* value
        );

        [VtblIndex(7)]
        HRESULT put_ColorOverrideSettings(
            [NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings *")]
                IColorOverrideSettings value
        );

        [VtblIndex(8)]
        HRESULT get_BrightnessOverrideSettings(
            [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")]
                IBrightnessOverrideSettings* value
        );

        [VtblIndex(9)]
        HRESULT put_BrightnessOverrideSettings(
            [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings *")]
                IBrightnessOverrideSettings value
        );

        [VtblIndex(10)]
        HRESULT get_CanOverride([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsOverrideActive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT GetCurrentDisplayEnhancementOverrideCapabilities(
            [NativeTypeName(
                "ABI::Windows::Graphics::Display::IDisplayEnhancementOverrideCapabilities **"
            )]
                IDisplayEnhancementOverrideCapabilities* value
        );

        [VtblIndex(13)]
        HRESULT RequestOverride();

        [VtblIndex(14)]
        HRESULT StopOverride();

        [VtblIndex(15)]
        HRESULT add_CanOverrideChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_CanOverrideChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_IsOverrideActiveChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        HRESULT remove_IsOverrideActiveChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT add_DisplayEnhancementOverrideCapabilitiesChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_Windows__CGraphics__CDisplay__CDisplayEnhancementOverrideCapabilitiesChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(20)]
        HRESULT remove_DisplayEnhancementOverrideCapabilitiesChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Graphics::Display::IColorOverrideSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IColorOverrideSettings*, int> get_ColorOverrideSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IColorOverrideSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IColorOverrideSettings, int> put_ColorOverrideSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBrightnessOverrideSettings*,
            int> get_BrightnessOverrideSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverrideSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBrightnessOverrideSettings,
            int> put_BrightnessOverrideSettings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanOverride;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOverrideActive;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IDisplayEnhancementOverrideCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayEnhancementOverrideCapabilities*,
            int> GetCurrentDisplayEnhancementOverrideCapabilities;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RequestOverride;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopOverride;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CanOverrideChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CanOverrideChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CDisplayEnhancementOverride_Windows__CGraphics__CDisplay__CDisplayEnhancementOverrideCapabilitiesChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DisplayEnhancementOverrideCapabilitiesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DisplayEnhancementOverrideCapabilitiesChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDisplayEnhancementOverride"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDisplayEnhancementOverride(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDisplayEnhancementOverride"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDisplayEnhancementOverride(Silk.NET.WinRT.IInspectable value)
    {
        return new IDisplayEnhancementOverride(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayEnhancementOverride"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayEnhancementOverride"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDisplayEnhancementOverride value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDisplayEnhancementOverride"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDisplayEnhancementOverride(Silk.NET.Windows.IUnknown value)
    {
        return new IDisplayEnhancementOverride(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayEnhancementOverride"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayEnhancementOverride"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDisplayEnhancementOverride value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
