// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("73DF80B0-27C6-40CE-B149-9CD41485A69E")]
[NativeTypeName("struct IUserDataTaskRecurrenceProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskRecurrenceProperties
    : IUserDataTaskRecurrenceProperties.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskRecurrenceProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserDataTaskRecurrenceProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataTaskRecurrenceProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Unit(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRecurrenceUnit *"
        )]
            UserDataTaskRecurrenceUnit* value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskRecurrenceProperties,
                UserDataTaskRecurrenceUnit*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Unit(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRecurrenceUnit"
        )]
            UserDataTaskRecurrenceUnit value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskRecurrenceProperties,
                UserDataTaskRecurrenceUnit,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Occurrences(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
            IReference<int>** value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<int>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Occurrences(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<int>*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Until(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<DateTime>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Until(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<DateTime>*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Interval([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IUserDataTaskRecurrenceProperties, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Interval([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IUserDataTaskRecurrenceProperties, int, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DaysOfWeek(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskDaysOfWeek_t **"
        )]
            IReference<UserDataTaskDaysOfWeek>** value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskRecurrenceProperties,
                IReference<UserDataTaskDaysOfWeek>**,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DaysOfWeek(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskDaysOfWeek_t *"
        )]
            IReference<UserDataTaskDaysOfWeek>* value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskRecurrenceProperties,
                IReference<UserDataTaskDaysOfWeek>*,
                int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_WeekOfMonth(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskWeekOfMonth_t **"
        )]
            IReference<UserDataTaskWeekOfMonth>** value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskRecurrenceProperties,
                IReference<UserDataTaskWeekOfMonth>**,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_WeekOfMonth(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskWeekOfMonth_t *"
        )]
            IReference<UserDataTaskWeekOfMonth>* value
    )
    {
        return (
            (delegate* unmanaged<
                IUserDataTaskRecurrenceProperties,
                IReference<UserDataTaskWeekOfMonth>*,
                int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Month(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
            IReference<int>** value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<int>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Month(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<int>*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Day(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
            IReference<int>** value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<int>**, int>)(
                (*lpVtbl)[20]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Day(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskRecurrenceProperties, IReference<int>*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Unit(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRecurrenceUnit *"
            )]
                UserDataTaskRecurrenceUnit* value
        );

        [VtblIndex(7)]
        HRESULT put_Unit(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRecurrenceUnit"
            )]
                UserDataTaskRecurrenceUnit value
        );

        [VtblIndex(8)]
        HRESULT get_Occurrences(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
                IReference<int>** value
        );

        [VtblIndex(9)]
        HRESULT put_Occurrences(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")]
                IReference<int>* value
        );

        [VtblIndex(10)]
        HRESULT get_Until(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(11)]
        HRESULT put_Until(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(12)]
        HRESULT get_Interval([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_Interval([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_DaysOfWeek(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskDaysOfWeek_t **"
            )]
                IReference<UserDataTaskDaysOfWeek>** value
        );

        [VtblIndex(15)]
        HRESULT put_DaysOfWeek(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskDaysOfWeek_t *"
            )]
                IReference<UserDataTaskDaysOfWeek>* value
        );

        [VtblIndex(16)]
        HRESULT get_WeekOfMonth(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskWeekOfMonth_t **"
            )]
                IReference<UserDataTaskWeekOfMonth>** value
        );

        [VtblIndex(17)]
        HRESULT put_WeekOfMonth(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskWeekOfMonth_t *"
            )]
                IReference<UserDataTaskWeekOfMonth>* value
        );

        [VtblIndex(18)]
        HRESULT get_Month(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
                IReference<int>** value
        );

        [VtblIndex(19)]
        HRESULT put_Month(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")]
                IReference<int>* value
        );

        [VtblIndex(20)]
        HRESULT get_Day(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
                IReference<int>** value
        );

        [VtblIndex(21)]
        HRESULT put_Day(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")]
                IReference<int>* value
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
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRecurrenceUnit *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataTaskRecurrenceUnit*, int> get_Unit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRecurrenceUnit) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataTaskRecurrenceUnit, int> put_Unit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>**, int> get_Occurrences;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>*, int> put_Occurrences;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_Until;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_Until;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Interval;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Interval;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskDaysOfWeek_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<UserDataTaskDaysOfWeek>**,
            int> get_DaysOfWeek;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskDaysOfWeek_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<UserDataTaskDaysOfWeek>*, int> put_DaysOfWeek;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskWeekOfMonth_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<UserDataTaskWeekOfMonth>**,
            int> get_WeekOfMonth;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskWeekOfMonth_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<UserDataTaskWeekOfMonth>*,
            int> put_WeekOfMonth;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>**, int> get_Month;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>*, int> put_Month;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>**, int> get_Day;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>*, int> put_Day;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataTaskRecurrenceProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataTaskRecurrenceProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataTaskRecurrenceProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataTaskRecurrenceProperties(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IUserDataTaskRecurrenceProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataTaskRecurrenceProperties"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataTaskRecurrenceProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IUserDataTaskRecurrenceProperties value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataTaskRecurrenceProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataTaskRecurrenceProperties(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IUserDataTaskRecurrenceProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataTaskRecurrenceProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataTaskRecurrenceProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IUserDataTaskRecurrenceProperties value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
