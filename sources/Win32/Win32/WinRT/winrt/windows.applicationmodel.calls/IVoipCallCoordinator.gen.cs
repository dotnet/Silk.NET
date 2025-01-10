// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4F118BCF-E8EF-4434-9C5F-A8D893FAFE79")]
[NativeTypeName("struct IVoipCallCoordinator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipCallCoordinator : IVoipCallCoordinator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipCallCoordinator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVoipCallCoordinator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReserveCallResourcesAsync(
        HSTRING taskEntryPoint,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CVoipPhoneCallResourceReservationStatus_t **"
        )]
            IAsyncOperation<VoipPhoneCallResourceReservationStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator,
                HSTRING,
                IAsyncOperation<VoipPhoneCallResourceReservationStatus>**,
                int>)((*lpVtbl)[6])
        )(this, taskEntryPoint, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_MuteStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipCallCoordinator_Windows__CApplicationModel__CCalls__CMuteChangeEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* muteChangeHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, muteChangeHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_MuteStateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IVoipCallCoordinator, EventRegistrationToken, int>)((*lpVtbl)[8])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestNewIncomingCall(
        HSTRING context,
        HSTRING contactName,
        HSTRING contactNumber,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass contactImage,
        HSTRING serviceName,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass brandingImage,
        HSTRING callDetails,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass ringtone,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
            VoipPhoneCallMedia media,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
            IVoipPhoneCall* call
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator,
                HSTRING,
                HSTRING,
                HSTRING,
                IUriRuntimeClass,
                HSTRING,
                IUriRuntimeClass,
                HSTRING,
                IUriRuntimeClass,
                VoipPhoneCallMedia,
                TimeSpan,
                IVoipPhoneCall*,
                int>)((*lpVtbl)[9])
        )(
            this,
            context,
            contactName,
            contactNumber,
            contactImage,
            serviceName,
            brandingImage,
            callDetails,
            ringtone,
            media,
            ringTimeout,
            call
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestNewOutgoingCall(
        HSTRING context,
        HSTRING contactName,
        HSTRING serviceName,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
            VoipPhoneCallMedia media,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
            IVoipPhoneCall* call
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator,
                HSTRING,
                HSTRING,
                HSTRING,
                VoipPhoneCallMedia,
                IVoipPhoneCall*,
                int>)((*lpVtbl)[10])
        )(this, context, contactName, serviceName, media, call);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT NotifyMuted()
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT NotifyUnmuted()
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RequestOutgoingUpgradeToVideoCall(
        Guid callUpgradeGuid,
        HSTRING context,
        HSTRING contactName,
        HSTRING serviceName,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
            IVoipPhoneCall* call
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator,
                Guid,
                HSTRING,
                HSTRING,
                HSTRING,
                IVoipPhoneCall*,
                int>)((*lpVtbl)[13])
        )(this, callUpgradeGuid, context, contactName, serviceName, call);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RequestIncomingUpgradeToVideoCall(
        HSTRING context,
        HSTRING contactName,
        HSTRING contactNumber,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass contactImage,
        HSTRING serviceName,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass brandingImage,
        HSTRING callDetails,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass ringtone,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
            IVoipPhoneCall* call
    )
    {
        return (
            (delegate* unmanaged<
                IVoipCallCoordinator,
                HSTRING,
                HSTRING,
                HSTRING,
                IUriRuntimeClass,
                HSTRING,
                IUriRuntimeClass,
                HSTRING,
                IUriRuntimeClass,
                TimeSpan,
                IVoipPhoneCall*,
                int>)((*lpVtbl)[14])
        )(
            this,
            context,
            contactName,
            contactNumber,
            contactImage,
            serviceName,
            brandingImage,
            callDetails,
            ringtone,
            ringTimeout,
            call
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TerminateCellularCall(Guid callUpgradeGuid)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, Guid, int>)((*lpVtbl)[15]))(
            this,
            callUpgradeGuid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CancelUpgrade(Guid callUpgradeGuid)
    {
        return ((delegate* unmanaged<IVoipCallCoordinator, Guid, int>)((*lpVtbl)[16]))(
            this,
            callUpgradeGuid
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReserveCallResourcesAsync(
            HSTRING taskEntryPoint,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CVoipPhoneCallResourceReservationStatus_t **"
            )]
                IAsyncOperation<VoipPhoneCallResourceReservationStatus>** operation
        );

        [VtblIndex(7)]
        HRESULT add_MuteStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipCallCoordinator_Windows__CApplicationModel__CCalls__CMuteChangeEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* muteChangeHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(8)]
        HRESULT remove_MuteStateChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT RequestNewIncomingCall(
            HSTRING context,
            HSTRING contactName,
            HSTRING contactNumber,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass contactImage,
            HSTRING serviceName,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass brandingImage,
            HSTRING callDetails,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass ringtone,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
                VoipPhoneCallMedia media,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
                IVoipPhoneCall* call
        );

        [VtblIndex(10)]
        HRESULT RequestNewOutgoingCall(
            HSTRING context,
            HSTRING contactName,
            HSTRING serviceName,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")]
                VoipPhoneCallMedia media,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
                IVoipPhoneCall* call
        );

        [VtblIndex(11)]
        HRESULT NotifyMuted();

        [VtblIndex(12)]
        HRESULT NotifyUnmuted();

        [VtblIndex(13)]
        HRESULT RequestOutgoingUpgradeToVideoCall(
            Guid callUpgradeGuid,
            HSTRING context,
            HSTRING contactName,
            HSTRING serviceName,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
                IVoipPhoneCall* call
        );

        [VtblIndex(14)]
        HRESULT RequestIncomingUpgradeToVideoCall(
            HSTRING context,
            HSTRING contactName,
            HSTRING contactNumber,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass contactImage,
            HSTRING serviceName,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass brandingImage,
            HSTRING callDetails,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass ringtone,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")]
                IVoipPhoneCall* call
        );

        [VtblIndex(15)]
        HRESULT TerminateCellularCall(Guid callUpgradeGuid);

        [VtblIndex(16)]
        HRESULT CancelUpgrade(Guid callUpgradeGuid);
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CVoipPhoneCallResourceReservationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<VoipPhoneCallResourceReservationStatus>**,
            int> ReserveCallResourcesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipCallCoordinator_Windows__CApplicationModel__CCalls__CMuteChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MuteStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MuteStateChanged;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IUriRuntimeClass,
            HSTRING,
            IUriRuntimeClass,
            HSTRING,
            IUriRuntimeClass,
            VoipPhoneCallMedia,
            TimeSpan,
            IVoipPhoneCall*,
            int> RequestNewIncomingCall;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            VoipPhoneCallMedia,
            IVoipPhoneCall*,
            int> RequestNewOutgoingCall;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyMuted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyUnmuted;

        [NativeTypeName(
            "HRESULT (GUID, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            HSTRING,
            HSTRING,
            HSTRING,
            IVoipPhoneCall*,
            int> RequestOutgoingUpgradeToVideoCall;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IUriRuntimeClass,
            HSTRING,
            IUriRuntimeClass,
            HSTRING,
            IUriRuntimeClass,
            TimeSpan,
            IVoipPhoneCall*,
            int> RequestIncomingUpgradeToVideoCall;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> TerminateCellularCall;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> CancelUpgrade;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVoipCallCoordinator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVoipCallCoordinator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVoipCallCoordinator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVoipCallCoordinator(Silk.NET.WinRT.IInspectable value)
    {
        return new IVoipCallCoordinator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoipCallCoordinator"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVoipCallCoordinator"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVoipCallCoordinator value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVoipCallCoordinator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVoipCallCoordinator(Silk.NET.Windows.IUnknown value)
    {
        return new IVoipCallCoordinator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoipCallCoordinator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVoipCallCoordinator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVoipCallCoordinator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
