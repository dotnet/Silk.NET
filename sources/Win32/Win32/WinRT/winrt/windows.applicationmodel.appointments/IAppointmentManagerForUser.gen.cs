// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("70261423-73CC-4660-B318-B01365302A03")]
[NativeTypeName("struct IAppointmentManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentManagerForUser
    : IAppointmentManagerForUser.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentManagerForUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppointmentManagerForUser, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppointmentManagerForUser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppointmentManagerForUser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppointmentManagerForUser, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppointmentManagerForUser, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppointmentManagerForUser, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAddAppointmentAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                IAppointment,
                Rect,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[6])
        )(this, appointment, selection, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAddAppointmentWithPlacementAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                IAppointment,
                Rect,
                Placement,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[7])
        )(this, appointment, selection, preferredPlacement, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowReplaceAppointmentAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                IAppointment,
                Rect,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[8])
        )(this, appointmentId, appointment, selection, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShowReplaceAppointmentWithPlacementAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                IAppointment,
                Rect,
                Placement,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[9])
        )(this, appointmentId, appointment, selection, preferredPlacement, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                IAppointment,
                Rect,
                Placement,
                WinRTDateTime,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[10])
        )(
            this,
            appointmentId,
            appointment,
            selection,
            preferredPlacement,
            instanceStartDate,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ShowRemoveAppointmentAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                Rect,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[11])
        )(this, appointmentId, selection, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowRemoveAppointmentWithPlacementAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                Rect,
                Placement,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[12])
        )(this, appointmentId, selection, preferredPlacement, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                Rect,
                Placement,
                WinRTDateTime,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[13])
        )(this, appointmentId, selection, preferredPlacement, instanceStartDate, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ShowTimeFrameAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime timeToShow,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                WinRTDateTime,
                TimeSpan,
                IAsyncAction*,
                int>)((*lpVtbl)[14])
        )(this, timeToShow, duration, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowAppointmentDetailsAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentManagerForUser, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[15]
            )
        )(this, appointmentId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ShowAppointmentDetailsWithDateAsync(
        HSTRING appointmentId,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                HSTRING,
                WinRTDateTime,
                IAsyncAction*,
                int>)((*lpVtbl)[16])
        )(this, appointmentId, instanceStartDate, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShowEditNewAppointmentAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                IAppointment,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[17])
        )(this, appointment, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RequestStoreAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType")]
            AppointmentStoreAccessType options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentManagerForUser,
                AppointmentStoreAccessType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[18])
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value)
    {
        return ((delegate* unmanaged<IAppointmentManagerForUser, IUser*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAddAppointmentAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(7)]
        HRESULT ShowAddAppointmentWithPlacementAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(8)]
        HRESULT ShowReplaceAppointmentAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(9)]
        HRESULT ShowReplaceAppointmentWithPlacementAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(10)]
        HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(11)]
        HRESULT ShowRemoveAppointmentAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(12)]
        HRESULT ShowRemoveAppointmentWithPlacementAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(13)]
        HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(14)]
        HRESULT ShowTimeFrameAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime timeToShow,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(15)]
        HRESULT ShowAppointmentDetailsAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(16)]
        HRESULT ShowAppointmentDetailsWithDateAsync(
            HSTRING appointmentId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(17)]
        HRESULT ShowEditNewAppointmentAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(18)]
        HRESULT RequestStoreAsync(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType"
            )]
                AppointmentStoreAccessType options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(19)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value);
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
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppointment,
            Rect,
            IAsyncOperation<HSTRING>**,
            int> ShowAddAppointmentAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppointment,
            Rect,
            Placement,
            IAsyncOperation<HSTRING>**,
            int> ShowAddAppointmentWithPlacementAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAppointment,
            Rect,
            IAsyncOperation<HSTRING>**,
            int> ShowReplaceAppointmentAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAppointment,
            Rect,
            Placement,
            IAsyncOperation<HSTRING>**,
            int> ShowReplaceAppointmentWithPlacementAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAppointment,
            Rect,
            Placement,
            WinRTDateTime,
            IAsyncOperation<HSTRING>**,
            int> ShowReplaceAppointmentWithPlacementAndDateAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Rect,
            IAsyncOperation<byte>**,
            int> ShowRemoveAppointmentAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Rect,
            Placement,
            IAsyncOperation<byte>**,
            int> ShowRemoveAppointmentWithPlacementAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Rect,
            Placement,
            WinRTDateTime,
            IAsyncOperation<byte>**,
            int> ShowRemoveAppointmentWithPlacementAndDateAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            TimeSpan,
            IAsyncAction*,
            int> ShowTimeFrameAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> ShowAppointmentDetailsAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            WinRTDateTime,
            IAsyncAction*,
            int> ShowAppointmentDetailsWithDateAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppointment,
            IAsyncOperation<HSTRING>**,
            int> ShowEditNewAppointmentAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentStore_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppointmentStoreAccessType,
            IAsyncOperation<IntPtr>**,
            int> RequestStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppointmentManagerForUser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppointmentManagerForUser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppointmentManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppointmentManagerForUser(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppointmentManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointmentManagerForUser"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointmentManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppointmentManagerForUser value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppointmentManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppointmentManagerForUser(Silk.NET.Windows.IUnknown value)
    {
        return new IAppointmentManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointmentManagerForUser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointmentManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppointmentManagerForUser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
