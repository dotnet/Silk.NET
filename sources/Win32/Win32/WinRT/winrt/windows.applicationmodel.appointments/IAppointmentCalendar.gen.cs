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

[Guid("5273819D-8339-3D4F-A02F-64084452BB5D")]
[NativeTypeName("struct IAppointmentCalendar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentCalendar : IAppointmentCalendar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentCalendar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppointmentCalendar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppointmentCalendar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppointmentCalendar, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, Color*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, HSTRING, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LocalId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess *"
        )]
            AppointmentCalendarOtherAppReadAccess* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentCalendar,
                AppointmentCalendarOtherAppReadAccess*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_OtherAppReadAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess"
        )]
            AppointmentCalendarOtherAppReadAccess value
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, AppointmentCalendarOtherAppReadAccess, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_OtherAppWriteAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess *"
        )]
            AppointmentCalendarOtherAppWriteAccess* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentCalendar,
                AppointmentCalendarOtherAppWriteAccess*,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_OtherAppWriteAccess(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess"
        )]
            AppointmentCalendarOtherAppWriteAccess value
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentCalendar,
                AppointmentCalendarOtherAppWriteAccess,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointmentCalendar, HSTRING*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SummaryCardView(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView *"
        )]
            AppointmentSummaryCardView* value
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, AppointmentSummaryCardView*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SummaryCardView(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView")]
            AppointmentSummaryCardView value
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, AppointmentSummaryCardView, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
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
                IAppointmentCalendar,
                WinRTDateTime,
                TimeSpan,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[18])
        )(this, rangeStart, rangeLength, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
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
                IAppointmentCalendar,
                WinRTDateTime,
                TimeSpan,
                IFindAppointmentsOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[19])
        )(this, rangeStart, rangeLength, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindExceptionsFromMasterAsync(
        HSTRING masterLocalId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentException_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[20]
            )
        )(this, masterLocalId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FindAllInstancesAsync(
        HSTRING masterLocalId,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentCalendar,
                HSTRING,
                WinRTDateTime,
                TimeSpan,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[21])
        )(this, masterLocalId, rangeStart, rangeLength, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FindAllInstancesAsyncWithOptions(
        HSTRING masterLocalId,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *")]
            IFindAppointmentsOptions pOptions,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAppointmentCalendar,
                HSTRING,
                WinRTDateTime,
                TimeSpan,
                IFindAppointmentsOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[22])
        )(this, masterLocalId, rangeStart, rangeLength, pOptions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetAppointmentAsync(
        HSTRING localId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[23]
            )
        )(this, localId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
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
                IAppointmentCalendar,
                HSTRING,
                WinRTDateTime,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[24])
        )(this, localId, instanceStartTime, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT FindUnexpandedAppointmentsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[25]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT FindUnexpandedAppointmentsAsyncWithOptions(
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
                IAppointmentCalendar,
                IFindAppointmentsOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[26])
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return ((delegate* unmanaged<IAppointmentCalendar, IAsyncAction*, int>)((*lpVtbl)[27]))(
            this,
            asyncAction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return ((delegate* unmanaged<IAppointmentCalendar, IAsyncAction*, int>)((*lpVtbl)[28]))(
            this,
            asyncAction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DeleteAppointmentAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, HSTRING, IAsyncAction*, int>)((*lpVtbl)[29])
        )(this, localId, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT DeleteAppointmentInstanceAsync(
        HSTRING localId,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, HSTRING, WinRTDateTime, IAsyncAction*, int>)(
                (*lpVtbl)[30]
            )
        )(this, localId, instanceStartTime, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SaveAppointmentAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
            IAppointment pAppointment,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IAppointmentCalendar, IAppointment, IAsyncAction*, int>)(
                (*lpVtbl)[31]
            )
        )(this, pAppointment, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_LocalId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess *"
            )]
                AppointmentCalendarOtherAppReadAccess* value
        );

        [VtblIndex(12)]
        HRESULT put_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess"
            )]
                AppointmentCalendarOtherAppReadAccess value
        );

        [VtblIndex(13)]
        HRESULT get_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess *"
            )]
                AppointmentCalendarOtherAppWriteAccess* value
        );

        [VtblIndex(14)]
        HRESULT put_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess"
            )]
                AppointmentCalendarOtherAppWriteAccess value
        );

        [VtblIndex(15)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_SummaryCardView(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView *"
            )]
                AppointmentSummaryCardView* value
        );

        [VtblIndex(17)]
        HRESULT put_SummaryCardView(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView"
            )]
                AppointmentSummaryCardView value
        );

        [VtblIndex(18)]
        HRESULT FindAppointmentsAsync(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(19)]
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

        [VtblIndex(20)]
        HRESULT FindExceptionsFromMasterAsync(
            HSTRING masterLocalId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentException_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(21)]
        HRESULT FindAllInstancesAsync(
            HSTRING masterLocalId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(22)]
        HRESULT FindAllInstancesAsyncWithOptions(
            HSTRING masterLocalId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime rangeStart,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan rangeLength,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *"
            )]
                IFindAppointmentsOptions pOptions,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(23)]
        HRESULT GetAppointmentAsync(
            HSTRING localId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(24)]
        HRESULT GetAppointmentInstanceAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(25)]
        HRESULT FindUnexpandedAppointmentsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(26)]
        HRESULT FindUnexpandedAppointmentsAsyncWithOptions(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *"
            )]
                IFindAppointmentsOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(27)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(28)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(29)]
        HRESULT DeleteAppointmentAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(30)]
        HRESULT DeleteAppointmentInstanceAsync(
            HSTRING localId,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime instanceStartTime,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(31)]
        HRESULT SaveAppointmentAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointment *")]
                IAppointment pAppointment,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DisplayColor;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LocalId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHidden;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppointmentCalendarOtherAppReadAccess*,
            int> get_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppReadAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppointmentCalendarOtherAppReadAccess,
            int> put_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppointmentCalendarOtherAppWriteAccess*,
            int> get_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentCalendarOtherAppWriteAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppointmentCalendarOtherAppWriteAccess,
            int> put_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentSummaryCardView*, int> get_SummaryCardView;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentSummaryCardView) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentSummaryCardView, int> put_SummaryCardView;

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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentException_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindExceptionsFromMasterAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            WinRTDateTime,
            TimeSpan,
            IAsyncOperation<IntPtr>**,
            int> FindAllInstancesAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            WinRTDateTime,
            TimeSpan,
            IFindAppointmentsOptions,
            IAsyncOperation<IntPtr>**,
            int> FindAllInstancesAsyncWithOptions;

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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> FindUnexpandedAppointmentsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IFindAppointmentsOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointment_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IFindAppointmentsOptions,
            IAsyncOperation<IntPtr>**,
            int> FindUnexpandedAppointmentsAsyncWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> SaveAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DeleteAppointmentAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            WinRTDateTime,
            IAsyncAction*,
            int> DeleteAppointmentInstanceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointment *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppointment, IAsyncAction*, int> SaveAppointmentAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppointmentCalendar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppointmentCalendar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppointmentCalendar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppointmentCalendar(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppointmentCalendar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointmentCalendar"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointmentCalendar"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppointmentCalendar value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppointmentCalendar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppointmentCalendar(Silk.NET.Windows.IUnknown value)
    {
        return new IAppointmentCalendar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointmentCalendar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointmentCalendar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppointmentCalendar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
