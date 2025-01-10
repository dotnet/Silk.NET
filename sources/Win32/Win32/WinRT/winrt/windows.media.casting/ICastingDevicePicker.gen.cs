// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DCD39924-0591-49BE-AACB-4B82EE756A95")]
[NativeTypeName("struct ICastingDevicePicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingDevicePicker : ICastingDevicePicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingDevicePicker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingDevicePicker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICastingDevicePicker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingDevicePicker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICastingDevicePicker, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICastingDevicePicker, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICastingDevicePicker, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Filter(
        [NativeTypeName("ABI::Windows::Media::Casting::ICastingDevicePickerFilter **")]
            ICastingDevicePickerFilter* value
    )
    {
        return (
            (delegate* unmanaged<ICastingDevicePicker, ICastingDevicePickerFilter*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Appearance(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")]
            IDevicePickerAppearance* value
    )
    {
        return (
            (delegate* unmanaged<ICastingDevicePicker, IDevicePickerAppearance*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_CastingDeviceSelected(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_Windows__CMedia__CCasting__CCastingDeviceSelectedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICastingDevicePicker,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_CastingDeviceSelected(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICastingDevicePicker, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_CastingDevicePickerDismissed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICastingDevicePicker,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_CastingDevicePickerDismissed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICastingDevicePicker, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection)
    {
        return ((delegate* unmanaged<ICastingDevicePicker, Rect, int>)((*lpVtbl)[12]))(
            this,
            selection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShowWithPlacement(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement
    )
    {
        return ((delegate* unmanaged<ICastingDevicePicker, Rect, Placement, int>)((*lpVtbl)[13]))(
            this,
            selection,
            preferredPlacement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Hide()
    {
        return ((delegate* unmanaged<ICastingDevicePicker, int>)((*lpVtbl)[14]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Filter(
            [NativeTypeName("ABI::Windows::Media::Casting::ICastingDevicePickerFilter **")]
                ICastingDevicePickerFilter* value
        );

        [VtblIndex(7)]
        HRESULT get_Appearance(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")]
                IDevicePickerAppearance* value
        );

        [VtblIndex(8)]
        HRESULT add_CastingDeviceSelected(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_Windows__CMedia__CCasting__CCastingDeviceSelectedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_CastingDeviceSelected(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_CastingDevicePickerDismissed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_CastingDevicePickerDismissed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection);

        [VtblIndex(13)]
        HRESULT ShowWithPlacement(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement
        );

        [VtblIndex(14)]
        HRESULT Hide();
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
            "HRESULT (ABI::Windows::Media::Casting::ICastingDevicePickerFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICastingDevicePickerFilter*, int> get_Filter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDevicePickerAppearance*, int> get_Appearance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_Windows__CMedia__CCasting__CCastingDeviceSelectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CastingDeviceSelected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_CastingDeviceSelected;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CastingDevicePickerDismissed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_CastingDevicePickerDismissed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect, int> Show;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Rect, Placement, int> ShowWithPlacement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Hide;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICastingDevicePicker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICastingDevicePicker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICastingDevicePicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICastingDevicePicker(Silk.NET.WinRT.IInspectable value)
    {
        return new ICastingDevicePicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICastingDevicePicker"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICastingDevicePicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICastingDevicePicker value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICastingDevicePicker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICastingDevicePicker(Silk.NET.Windows.IUnknown value)
    {
        return new ICastingDevicePicker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICastingDevicePicker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICastingDevicePicker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICastingDevicePicker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
