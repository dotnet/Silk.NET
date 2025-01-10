// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BAD30276-83B6-5732-9C38-0C206546196A")]
[NativeTypeName("struct IPhoneIncomingCallDismissedTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
)]
public unsafe partial struct IPhoneIncomingCallDismissedTriggerDetails
    : IPhoneIncomingCallDismissedTriggerDetails.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneIncomingCallDismissedTriggerDetails));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    public HRESULT get_LineId(Guid* value)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, Guid*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    public HRESULT get_PhoneNumber(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, HSTRING*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, HSTRING*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DismissalTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, WinRTDateTime*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    public HRESULT get_TextReplyMessage(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IPhoneIncomingCallDismissedTriggerDetails, HSTRING*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Reason(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Calls::Background::PhoneIncomingCallDismissedReason *"
        )]
            PhoneIncomingCallDismissedReason* value
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneIncomingCallDismissedTriggerDetails,
                PhoneIncomingCallDismissedReason*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        HRESULT get_LineId(Guid* value);

        [VtblIndex(7)]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        HRESULT get_PhoneNumber(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        HRESULT get_DismissalTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(10)]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        HRESULT get_TextReplyMessage(HSTRING* value);

        [VtblIndex(11)]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        HRESULT get_Reason(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::Background::PhoneIncomingCallDismissedReason *"
            )]
                PhoneIncomingCallDismissedReason* value
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Guid*, int> get_LineId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PhoneNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_DismissalTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TextReplyMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::Background::PhoneIncomingCallDismissedReason *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, PhoneIncomingCallDismissedReason*, int> get_Reason;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneIncomingCallDismissedTriggerDetails(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneIncomingCallDismissedTriggerDetails(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPhoneIncomingCallDismissedTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPhoneIncomingCallDismissedTriggerDetails value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneIncomingCallDismissedTriggerDetails(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPhoneIncomingCallDismissedTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneIncomingCallDismissedTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPhoneIncomingCallDismissedTriggerDetails value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
