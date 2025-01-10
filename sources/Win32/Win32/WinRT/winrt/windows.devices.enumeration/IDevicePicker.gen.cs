// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("84997AA2-034A-4440-8813-7D0BD479BF5A")]
[NativeTypeName("struct IDevicePicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePicker : IDevicePicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDevicePicker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDevicePicker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDevicePicker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDevicePicker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDevicePicker, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDevicePicker, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDevicePicker, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Filter(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerFilter **")]
            IDevicePickerFilter* filter
    )
    {
        return ((delegate* unmanaged<IDevicePicker, IDevicePickerFilter*, int>)((*lpVtbl)[6]))(
            this,
            filter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Appearance(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")]
            IDevicePickerAppearance* value
    )
    {
        return ((delegate* unmanaged<IDevicePicker, IDevicePickerAppearance*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RequestedProperties(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IDevicePicker, IVector<HSTRING>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_DeviceSelected(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceSelectedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDevicePicker,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_DeviceSelected(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IDevicePicker, EventRegistrationToken, int>)((*lpVtbl)[10]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_DisconnectButtonClicked(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceDisconnectButtonClickedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDevicePicker,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_DisconnectButtonClicked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IDevicePicker, EventRegistrationToken, int>)((*lpVtbl)[12]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_DevicePickerDismissed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDevicePicker,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_DevicePickerDismissed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IDevicePicker, EventRegistrationToken, int>)((*lpVtbl)[14]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection)
    {
        return ((delegate* unmanaged<IDevicePicker, Rect, int>)((*lpVtbl)[15]))(this, selection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ShowWithPlacement(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement
    )
    {
        return ((delegate* unmanaged<IDevicePicker, Rect, Placement, int>)((*lpVtbl)[16]))(
            this,
            selection,
            placement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PickSingleDeviceAsync(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDevicePicker, Rect, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[17]
            )
        )(this, selection, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT PickSingleDeviceAsyncWithPlacement(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDevicePicker, Rect, Placement, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, selection, placement, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Hide()
    {
        return ((delegate* unmanaged<IDevicePicker, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetDisplayStatus(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
            IDeviceInformation device,
        HSTRING status,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePickerDisplayStatusOptions")]
            DevicePickerDisplayStatusOptions options
    )
    {
        return (
            (delegate* unmanaged<
                IDevicePicker,
                IDeviceInformation,
                HSTRING,
                DevicePickerDisplayStatusOptions,
                int>)((*lpVtbl)[20])
        )(this, device, status, options);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Filter(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerFilter **")]
                IDevicePickerFilter* filter
        );

        [VtblIndex(7)]
        HRESULT get_Appearance(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")]
                IDevicePickerAppearance* value
        );

        [VtblIndex(8)]
        HRESULT get_RequestedProperties(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(9)]
        HRESULT add_DeviceSelected(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceSelectedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_DeviceSelected(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_DisconnectButtonClicked(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceDisconnectButtonClickedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_DisconnectButtonClicked(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_DevicePickerDismissed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_DevicePickerDismissed(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection);

        [VtblIndex(16)]
        HRESULT ShowWithPlacement(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement
        );

        [VtblIndex(17)]
        HRESULT PickSingleDeviceAsync(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(18)]
        HRESULT PickSingleDeviceAsyncWithPlacement(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(19)]
        HRESULT Hide();

        [VtblIndex(20)]
        HRESULT SetDisplayStatus(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
                IDeviceInformation device,
            HSTRING status,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePickerDisplayStatusOptions")]
                DevicePickerDisplayStatusOptions options
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
            "HRESULT (ABI::Windows::Devices::Enumeration::IDevicePickerFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDevicePickerFilter*, int> get_Filter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDevicePickerAppearance*, int> get_Appearance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_RequestedProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceSelectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DeviceSelected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DeviceSelected;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceDisconnectButtonClickedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DisconnectButtonClicked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DisconnectButtonClicked;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DevicePickerDismissed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DevicePickerDismissed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect, int> Show;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Rect, Placement, int> ShowWithPlacement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Rect,
            IAsyncOperation<IntPtr>**,
            int> PickSingleDeviceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Rect,
            Placement,
            IAsyncOperation<IntPtr>**,
            int> PickSingleDeviceAsyncWithPlacement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Hide;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation *, HSTRING, ABI::Windows::Devices::Enumeration::DevicePickerDisplayStatusOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDeviceInformation,
            HSTRING,
            DevicePickerDisplayStatusOptions,
            int> SetDisplayStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDevicePicker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDevicePicker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDevicePicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDevicePicker(Silk.NET.WinRT.IInspectable value)
    {
        return new IDevicePicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDevicePicker"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDevicePicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDevicePicker value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDevicePicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDevicePicker(Silk.NET.Windows.IUnknown value)
    {
        return new IDevicePicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDevicePicker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDevicePicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDevicePicker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
