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

[Guid("A461918C-7A47-4D96-96C9-15CD8A05A735")]
[NativeTypeName("struct IAppointmentStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentStore : IAppointmentStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppointmentStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppointmentStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppointmentStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppointmentStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppointmentStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppointmentStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeTracker(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeTracker **"
        )]
            IAppointmentStoreChangeTracker* value
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, IAppointmentStoreChangeTracker*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAppointmentCalendarAsync(
        HSTRING name,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, name, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAppointmentCalendarAsync(
        HSTRING calendarId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, calendarId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAppointmentAsync(
        HSTRING localId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, localId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAppointmentInstanceAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                HSTRING,
                WinRTDateTime,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, localId, instanceStartTime, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindAppointmentCalendarsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[11])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindAppointmentCalendarsAsyncWithOptions(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::FindAppointmentCalendarsOptions"
        )]
            FindAppointmentCalendarsOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                FindAppointmentCalendarsOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindAppointmentsAsync(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                WinRTDateTime,
                TimeSpan,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, rangeStart, rangeLength, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT FindAppointmentsAsyncWithOptions(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")]
            IFindAppointmentsOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                WinRTDateTime,
                TimeSpan,
                IFindAppointmentsOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[14])
        )(this, rangeStart, rangeLength, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FindConflictAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, IAppointment, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, appointment, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FindConflictAsyncWithInstanceStart(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                IAppointment,
                WinRTDateTime,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[16])
        )(this, appointment, instanceStartTime, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT MoveAppointmentAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendar *")]
            IAppointmentCalendar destinationCalendar,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                IAppointment,
                IAppointmentCalendar,
                IAsyncAction*,
                int>)((*lpVtbl)[17])
        )(this, appointment, destinationCalendar, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ShowAddAppointmentAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                IAppointment,
                Rect,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[18])
        )(this, appointment, selection, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowReplaceAppointmentAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                HSTRING,
                IAppointment,
                Rect,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[19])
        )(this, localId, appointment, selection, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                HSTRING,
                IAppointment,
                Rect,
                Placement,
                WinRTDateTime,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[20])
        )(this, localId, appointment, selection, preferredPlacement, instanceStartDate, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ShowRemoveAppointmentAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, Rect, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[21]
            )
        )(this, localId, selection, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentStore,
                HSTRING,
                Rect,
                Placement,
                WinRTDateTime,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[22])
        )(this, localId, selection, preferredPlacement, instanceStartDate, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ShowAppointmentDetailsAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, IAsyncAction*, int>)((*lpVtbl)[23])
        )(this, localId, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ShowAppointmentDetailsWithDateAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, WinRTDateTime, IAsyncAction*, int>)(
                (*lpVtbl)[24]
            )
        )(this, localId, instanceStartDate, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ShowEditNewAppointmentAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment appointment,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, IAppointment, IAsyncOperation<HSTRING>**, int>)(
                (*lpVtbl)[25]
            )
        )(this, appointment, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT FindLocalIdsFromRoamingIdAsync(
        HSTRING roamingId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IAppointmentStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[26]
            )
        )(this, roamingId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeTracker(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeTracker **"
            )]
                IAppointmentStoreChangeTracker* value
        );

        [VtblIndex(7)]
        HRESULT CreateAppointmentCalendarAsync(
            HSTRING name,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT GetAppointmentCalendarAsync(
            HSTRING calendarId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT GetAppointmentAsync(
            HSTRING localId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT GetAppointmentInstanceAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT FindAppointmentCalendarsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(12)]
        HRESULT FindAppointmentCalendarsAsyncWithOptions(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::FindAppointmentCalendarsOptions"
            )]
                FindAppointmentCalendarsOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(13)]
        HRESULT FindAppointmentsAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(14)]
        HRESULT FindAppointmentsAsyncWithOptions(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *"
            )]
                IFindAppointmentsOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(15)]
        HRESULT FindConflictAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(16)]
        HRESULT FindConflictAsyncWithInstanceStart(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(17)]
        HRESULT MoveAppointmentAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendar *")]
                IAppointmentCalendar destinationCalendar,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(18)]
        HRESULT ShowAddAppointmentAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(19)]
        HRESULT ShowReplaceAppointmentAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(20)]
        HRESULT ShowReplaceAppointmentWithPlacementAndDateAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(21)]
        HRESULT ShowRemoveAppointmentAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(22)]
        HRESULT ShowRemoveAppointmentWithPlacementAndDateAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(23)]
        HRESULT ShowAppointmentDetailsAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(24)]
        HRESULT ShowAppointmentDetailsWithDateAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartDate,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(25)]
        HRESULT ShowEditNewAppointmentAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment appointment,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(26)]
        HRESULT FindLocalIdsFromRoamingIdAsync(
            HSTRING roamingId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentStoreChangeTracker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppointmentStoreChangeTracker*, int> get_ChangeTracker;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateAppointmentCalendarAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetAppointmentCalendarAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetAppointmentAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            WinRTDateTime,
            IAsyncOperation<IntPtr>**,
            int> GetAppointmentInstanceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> FindAppointmentCalendarsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::FindAppointmentCalendarsOptions, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            FindAppointmentCalendarsOptions,
            IAsyncOperation<IntPtr>**,
            int> FindAppointmentCalendarsAsyncWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            TimeSpan,
            IAsyncOperation<IntPtr>**,
            int> FindAppointmentsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WinRTDateTime,
            TimeSpan,
            IFindAppointmentsOptions,
            IAsyncOperation<IntPtr>**,
            int> FindAppointmentsAsyncWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppointment,
            IAsyncOperation<IntPtr>**,
            int> FindConflictAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointmentConflictResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppointment,
            WinRTDateTime,
            IAsyncOperation<IntPtr>**,
            int> FindConflictAsyncWithInstanceStart;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::ApplicationModel::Appointments::IAppointmentCalendar *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppointment,
            IAppointmentCalendar,
            IAsyncAction*,
            int> MoveAppointmentAsync;

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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindLocalIdsFromRoamingIdAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppointmentStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppointmentStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppointmentStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppointmentStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppointmentStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointmentStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointmentStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppointmentStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppointmentStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppointmentStore(Silk.NET.Windows.IUnknown value)
    {
        return new IAppointmentStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointmentStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointmentStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppointmentStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
