// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("42344CB7-6ABC-40FF-9CE7-73B85301B900")]
[NativeTypeName("struct IGpioPinProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioPinProvider : IGpioPinProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioPinProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGpioPinProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGpioPinProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGpioPinProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGpioPinProvider, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGpioPinProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGpioPinProvider, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ValueChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CProvider__CIGpioPinProvider_Windows__CDevices__CGpio__CProvider__CGpioPinProviderValueChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IGpioPinProvider,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ValueChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IGpioPinProvider, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DebounceTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IGpioPinProvider, TimeSpan*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DebounceTimeout(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IGpioPinProvider, TimeSpan, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PinNumber([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IGpioPinProvider, int*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SharingMode(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode *")]
            ProviderGpioSharingMode* value
    )
    {
        return (
            (delegate* unmanaged<IGpioPinProvider, ProviderGpioSharingMode*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsDriveModeSupported(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")]
            ProviderGpioPinDriveMode driveMode,
        [NativeTypeName("boolean *")] byte* supported
    )
    {
        return (
            (delegate* unmanaged<IGpioPinProvider, ProviderGpioPinDriveMode, byte*, int>)(
                (*lpVtbl)[12]
            )
        )(this, driveMode, supported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDriveMode(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode *")]
            ProviderGpioPinDriveMode* value
    )
    {
        return (
            (delegate* unmanaged<IGpioPinProvider, ProviderGpioPinDriveMode*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetDriveMode(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")]
            ProviderGpioPinDriveMode value
    )
    {
        return (
            (delegate* unmanaged<IGpioPinProvider, ProviderGpioPinDriveMode, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Write(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue")]
            ProviderGpioPinValue value
    )
    {
        return ((delegate* unmanaged<IGpioPinProvider, ProviderGpioPinValue, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Read(
        [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue *")]
            ProviderGpioPinValue* value
    )
    {
        return ((delegate* unmanaged<IGpioPinProvider, ProviderGpioPinValue*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ValueChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CProvider__CIGpioPinProvider_Windows__CDevices__CGpio__CProvider__CGpioPinProviderValueChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_ValueChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_DebounceTimeout(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        HRESULT put_DebounceTimeout(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(10)]
        HRESULT get_PinNumber([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_SharingMode(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode *")]
                ProviderGpioSharingMode* value
        );

        [VtblIndex(12)]
        HRESULT IsDriveModeSupported(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")]
                ProviderGpioPinDriveMode driveMode,
            [NativeTypeName("boolean *")] byte* supported
        );

        [VtblIndex(13)]
        HRESULT GetDriveMode(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode *")]
                ProviderGpioPinDriveMode* value
        );

        [VtblIndex(14)]
        HRESULT SetDriveMode(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode")]
                ProviderGpioPinDriveMode value
        );

        [VtblIndex(15)]
        HRESULT Write(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue")]
                ProviderGpioPinValue value
        );

        [VtblIndex(16)]
        HRESULT Read(
            [NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue *")]
                ProviderGpioPinValue* value
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGpio__CProvider__CIGpioPinProvider_Windows__CDevices__CGpio__CProvider__CGpioPinProviderValueChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ValueChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ValueChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_DebounceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_DebounceTimeout;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PinNumber;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioSharingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderGpioSharingMode*, int> get_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ProviderGpioPinDriveMode,
            byte*,
            int> IsDriveModeSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderGpioPinDriveMode*, int> GetDriveMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinDriveMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderGpioPinDriveMode, int> SetDriveMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderGpioPinValue, int> Write;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProviderGpioPinValue*, int> Read;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGpioPinProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGpioPinProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGpioPinProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGpioPinProvider(Silk.NET.WinRT.IInspectable value)
    {
        return new IGpioPinProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioPinProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioPinProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGpioPinProvider value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGpioPinProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGpioPinProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IGpioPinProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioPinProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioPinProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGpioPinProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
