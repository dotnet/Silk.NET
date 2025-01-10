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

[Guid("5E85983C-540F-3452-9B5C-0DD7AD4C65A2")]
[NativeTypeName("struct IAppointment2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointment2 : IAppointment2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointment2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppointment2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppointment2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppointment2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppointment2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppointment2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LocalId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CalendarId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RoamingId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RoamingId(HSTRING value)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OriginalStartTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return ((delegate* unmanaged<IAppointment2, IReference<DateTime>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsResponseRequested([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointment2, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_IsResponseRequested([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppointment2, byte, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AllowNewTimeProposal([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointment2, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AllowNewTimeProposal([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppointment2, byte, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_OnlineMeetingLink(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_OnlineMeetingLink(HSTRING value)
    {
        return ((delegate* unmanaged<IAppointment2, HSTRING, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ReplyTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return ((delegate* unmanaged<IAppointment2, IReference<DateTime>**, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ReplyTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return ((delegate* unmanaged<IAppointment2, IReference<DateTime>*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_UserResponse(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse *"
        )]
            AppointmentParticipantResponse* value
    )
    {
        return (
            (delegate* unmanaged<IAppointment2, AppointmentParticipantResponse*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_UserResponse(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse"
        )]
            AppointmentParticipantResponse value
    )
    {
        return (
            (delegate* unmanaged<IAppointment2, AppointmentParticipantResponse, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_HasInvitees([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointment2, byte*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_IsCanceledMeeting([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointment2, byte*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_IsCanceledMeeting([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppointment2, byte, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_IsOrganizedByUser([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppointment2, byte*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_IsOrganizedByUser([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppointment2, byte, int>)((*lpVtbl)[25]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LocalId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CalendarId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RoamingId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_RoamingId(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_OriginalStartTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(11)]
        HRESULT get_IsResponseRequested([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_IsResponseRequested([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_AllowNewTimeProposal([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_AllowNewTimeProposal([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_OnlineMeetingLink(HSTRING* value);

        [VtblIndex(16)]
        HRESULT put_OnlineMeetingLink(HSTRING value);

        [VtblIndex(17)]
        HRESULT get_ReplyTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(18)]
        HRESULT put_ReplyTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(19)]
        HRESULT get_UserResponse(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse *"
            )]
                AppointmentParticipantResponse* value
        );

        [VtblIndex(20)]
        HRESULT put_UserResponse(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse"
            )]
                AppointmentParticipantResponse value
        );

        [VtblIndex(21)]
        HRESULT get_HasInvitees([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT get_IsCanceledMeeting([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(23)]
        HRESULT put_IsCanceledMeeting([NativeTypeName("boolean")] byte value);

        [VtblIndex(24)]
        HRESULT get_IsOrganizedByUser([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT put_IsOrganizedByUser([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LocalId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CalendarId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RoamingId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_RoamingId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_OriginalStartTime;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsResponseRequested;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsResponseRequested;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowNewTimeProposal;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllowNewTimeProposal;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_OnlineMeetingLink;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_OnlineMeetingLink;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_ReplyTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_ReplyTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentParticipantResponse*, int> get_UserResponse;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Appointments::AppointmentParticipantResponse) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppointmentParticipantResponse, int> put_UserResponse;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasInvitees;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCanceledMeeting;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsCanceledMeeting;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOrganizedByUser;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsOrganizedByUser;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppointment2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppointment2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppointment2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppointment2(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppointment2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointment2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointment2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppointment2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppointment2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppointment2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppointment2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppointment2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppointment2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppointment2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
