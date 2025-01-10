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

[Guid("DD002F2F-2BDD-4076-90A3-22C275312965")]
[NativeTypeName("struct IAppointment : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointment : IAppointment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointment));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppointment, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppointment, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppointment, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppointment, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppointment, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StartTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IAppointment, WinRTDateTime*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_StartTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
    )
    {
        return ((delegate* unmanaged<IAppointment, WinRTDateTime, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IAppointment, TimeSpan*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IAppointment, TimeSpan, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Location(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Location(HSTRING value)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Subject(HSTRING value)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Details(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Details(HSTRING value)
    {
        return ((delegate* unmanaged<IAppointment, HSTRING, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Reminder(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IReference<TimeSpan>** value
    )
    {
        return ((delegate* unmanaged<IAppointment, IReference<TimeSpan>**, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Reminder(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *"
        )]
            IReference<TimeSpan>* value
    )
    {
        return ((delegate* unmanaged<IAppointment, IReference<TimeSpan>*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Organizer(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentParticipant **")]
            IAppointmentParticipant* value
    )
    {
        return ((delegate* unmanaged<IAppointment, IAppointmentParticipant*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Organizer(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentParticipant *")]
            IAppointmentParticipant value
    )
    {
        return ((delegate* unmanaged<IAppointment, IAppointmentParticipant, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Invitees(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppointments__CAppointmentInvitee_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IAppointment, IVector<IntPtr>**, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Recurrence(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence **")]
            IAppointmentRecurrence* value
    )
    {
        return ((delegate* unmanaged<IAppointment, IAppointmentRecurrence*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_Recurrence(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence *")]
            IAppointmentRecurrence value
    )
    {
        return ((delegate* unmanaged<IAppointment, IAppointmentRecurrence, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_BusyStatus(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentBusyStatus *")]
            AppointmentBusyStatus* value
    )
    {
        return ((delegate* unmanaged<IAppointment, AppointmentBusyStatus*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_BusyStatus(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentBusyStatus")]
            AppointmentBusyStatus value
    )
    {
        return ((delegate* unmanaged<IAppointment, AppointmentBusyStatus, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_AllDay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointment, byte*, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_AllDay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppointment, byte, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Sensitivity(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSensitivity *")]
            AppointmentSensitivity* value
    )
    {
        return ((delegate* unmanaged<IAppointment, AppointmentSensitivity*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Sensitivity(
        [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSensitivity")]
            AppointmentSensitivity value
    )
    {
        return ((delegate* unmanaged<IAppointment, AppointmentSensitivity, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Uri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return ((delegate* unmanaged<IAppointment, IUriRuntimeClass*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_Uri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return ((delegate* unmanaged<IAppointment, IUriRuntimeClass, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StartTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        HRESULT put_StartTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
        );

        [VtblIndex(8)]
        HRESULT get_Duration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_Location(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Location(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Subject(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_Details(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_Details(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_Reminder(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IReference<TimeSpan>** value
        );

        [VtblIndex(17)]
        HRESULT put_Reminder(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *"
            )]
                IReference<TimeSpan>* value
        );

        [VtblIndex(18)]
        HRESULT get_Organizer(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IAppointmentParticipant **"
            )]
                IAppointmentParticipant* value
        );

        [VtblIndex(19)]
        HRESULT put_Organizer(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IAppointmentParticipant *"
            )]
                IAppointmentParticipant value
        );

        [VtblIndex(20)]
        HRESULT get_Invitees(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppointments__CAppointmentInvitee_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(21)]
        HRESULT get_Recurrence(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence **"
            )]
                IAppointmentRecurrence* value
        );

        [VtblIndex(22)]
        HRESULT put_Recurrence(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence *"
            )]
                IAppointmentRecurrence value
        );

        [VtblIndex(23)]
        HRESULT get_BusyStatus(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentBusyStatus *"
            )]
                AppointmentBusyStatus* value
        );

        [VtblIndex(24)]
        HRESULT put_BusyStatus(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentBusyStatus")]
                AppointmentBusyStatus value
        );

        [VtblIndex(25)]
        HRESULT get_AllDay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(26)]
        HRESULT put_AllDay([NativeTypeName("boolean")] byte value);

        [VtblIndex(27)]
        HRESULT get_Sensitivity(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentSensitivity *"
            )]
                AppointmentSensitivity* value
        );

        [VtblIndex(28)]
        HRESULT put_Sensitivity(
            [NativeTypeName("ABI::Windows::ApplicationModel::Appointments::AppointmentSensitivity")]
                AppointmentSensitivity value
        );

        [VtblIndex(29)]
        HRESULT get_Uri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(30)]
        HRESULT put_Uri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int> put_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_Duration;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Location;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Location;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Subject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Details;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Details;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>**, int> get_Reminder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>*, int> put_Reminder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentParticipant **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppointmentParticipant*, int> get_Organizer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentParticipant *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppointmentParticipant, int> put_Organizer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CAppointments__CAppointmentInvitee_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Invitees;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppointmentRecurrence*, int> get_Recurrence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::IAppointmentRecurrence *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppointmentRecurrence, int> put_Recurrence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentBusyStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentBusyStatus*, int> get_BusyStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentBusyStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentBusyStatus, int> put_BusyStatus;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllDay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllDay;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentSensitivity *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentSensitivity*, int> get_Sensitivity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentSensitivity) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentSensitivity, int> put_Sensitivity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_Uri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_Uri;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppointment"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppointment(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppointment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppointment(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppointment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointment"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointment"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppointment value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppointment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppointment(Silk.NET.Windows.IUnknown value)
    {
        return new IAppointment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointment"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppointment value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
