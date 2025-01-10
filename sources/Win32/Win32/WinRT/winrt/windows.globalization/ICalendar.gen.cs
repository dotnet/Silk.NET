// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CA30221D-86D9-40FB-A26B-D44EB7CF08EA")]
[NativeTypeName("struct ICalendar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICalendar : ICalendar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICalendar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICalendar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICalendar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICalendar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICalendar, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICalendar, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(
        [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar* value
    )
    {
        return ((delegate* unmanaged<ICalendar, ICalendar*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetToMin()
    {
        return ((delegate* unmanaged<ICalendar, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetToMax()
    {
        return ((delegate* unmanaged<ICalendar, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Languages(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<ICalendar, IVectorView<HSTRING>**, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NumeralSystem(HSTRING* value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_NumeralSystem(HSTRING value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCalendarSystem(HSTRING* value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ChangeCalendarSystem(HSTRING value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetClock(HSTRING* value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ChangeClock(HSTRING value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* result
    )
    {
        return ((delegate* unmanaged<ICalendar, WinRTDateTime*, int>)((*lpVtbl)[16]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
    )
    {
        return ((delegate* unmanaged<ICalendar, WinRTDateTime, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetToNow()
    {
        return ((delegate* unmanaged<ICalendar, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_FirstEra([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_LastEra([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_NumberOfEras([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Era([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Era([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT AddEras([NativeTypeName("INT32")] int eras)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[24]))(this, eras);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT EraAsFullString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[25]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT EraAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[26]))(
            this,
            idealLength,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_FirstYearInThisEra([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_LastYearInThisEra([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_NumberOfYearsInThisEra([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[29]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Year([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_Year([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[31]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT AddYears([NativeTypeName("INT32")] int years)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[32]))(this, years);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT YearAsString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[33]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT YearAsTruncatedString(
        [NativeTypeName("INT32")] int remainingDigits,
        HSTRING* result
    )
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[34]))(
            this,
            remainingDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT YearAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[35]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_FirstMonthInThisYear([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[36]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_LastMonthInThisYear([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[37]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_NumberOfMonthsInThisYear([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[38]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Month([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[39]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_Month([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[40]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT AddMonths([NativeTypeName("INT32")] int months)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[41]))(this, months);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT MonthAsFullString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[42]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT MonthAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[43]))(
            this,
            idealLength,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT MonthAsFullSoloString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[44]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT MonthAsSoloString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[45]))(
            this,
            idealLength,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT MonthAsNumericString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[46]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT MonthAsPaddedNumericString(
        [NativeTypeName("INT32")] int minDigits,
        HSTRING* result
    )
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[47]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT AddWeeks([NativeTypeName("INT32")] int weeks)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[48]))(this, weeks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_FirstDayInThisMonth([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[49]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_LastDayInThisMonth([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[50]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_NumberOfDaysInThisMonth([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[51]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_Day([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[52]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_Day([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[53]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT AddDays([NativeTypeName("INT32")] int days)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[54]))(this, days);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT DayAsString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[55]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT DayAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[56]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_DayOfWeek(
        [NativeTypeName("ABI::Windows::Globalization::DayOfWeek *")] DayOfWeek* value
    )
    {
        return ((delegate* unmanaged<ICalendar, DayOfWeek*, int>)((*lpVtbl)[57]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT DayOfWeekAsFullString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[58]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT DayOfWeekAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[59]))(
            this,
            idealLength,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT DayOfWeekAsFullSoloString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[60]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT DayOfWeekAsSoloString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[61]))(
            this,
            idealLength,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_FirstPeriodInThisDay([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[62]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_LastPeriodInThisDay([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[63]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_NumberOfPeriodsInThisDay([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[64]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_Period([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[65]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_Period([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[66]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT AddPeriods([NativeTypeName("INT32")] int periods)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[67]))(this, periods);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT PeriodAsFullString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[68]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT PeriodAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[69]))(
            this,
            idealLength,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_FirstHourInThisPeriod([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[70]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_LastHourInThisPeriod([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[71]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_NumberOfHoursInThisPeriod([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[72]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_Hour([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[73]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT put_Hour([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[74]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT AddHours([NativeTypeName("INT32")] int hours)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[75]))(this, hours);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT HourAsString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[76]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT HourAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[77]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_Minute([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[78]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_Minute([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[79]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT AddMinutes([NativeTypeName("INT32")] int minutes)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[80]))(this, minutes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT MinuteAsString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[81]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT MinuteAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[82]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_Second([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[83]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT put_Second([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[84]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT AddSeconds([NativeTypeName("INT32")] int seconds)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[85]))(this, seconds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT SecondAsString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[86]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT SecondAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[87]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_Nanosecond([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[88]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_Nanosecond([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[89]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT AddNanoseconds([NativeTypeName("INT32")] int nanoseconds)
    {
        return ((delegate* unmanaged<ICalendar, int, int>)((*lpVtbl)[90]))(this, nanoseconds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT NanosecondAsString(HSTRING* result)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[91]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT NanosecondAsPaddedString(
        [NativeTypeName("INT32")] int minDigits,
        HSTRING* result
    )
    {
        return ((delegate* unmanaged<ICalendar, int, HSTRING*, int>)((*lpVtbl)[92]))(
            this,
            minDigits,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT Compare(
        [NativeTypeName("ABI::Windows::Globalization::ICalendar *")] ICalendar other,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return ((delegate* unmanaged<ICalendar, ICalendar, int*, int>)((*lpVtbl)[93]))(
            this,
            other,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT CompareDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime other,
        [NativeTypeName("INT32 *")] int* result
    )
    {
        return ((delegate* unmanaged<ICalendar, WinRTDateTime, int*, int>)((*lpVtbl)[94]))(
            this,
            other,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT CopyTo(
        [NativeTypeName("ABI::Windows::Globalization::ICalendar *")] ICalendar other
    )
    {
        return ((delegate* unmanaged<ICalendar, ICalendar, int>)((*lpVtbl)[95]))(this, other);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_FirstMinuteInThisHour([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[96]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_LastMinuteInThisHour([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[97]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_NumberOfMinutesInThisHour([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[98]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_FirstSecondInThisMinute([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[99]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_LastSecondInThisMinute([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[100]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_NumberOfSecondsInThisMinute([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICalendar, int*, int>)((*lpVtbl)[101]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_ResolvedLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged<ICalendar, HSTRING*, int>)((*lpVtbl)[102]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_IsDaylightSavingTime([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICalendar, byte*, int>)((*lpVtbl)[103]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Clone(
            [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar* value
        );

        [VtblIndex(7)]
        HRESULT SetToMin();

        [VtblIndex(8)]
        HRESULT SetToMax();

        [VtblIndex(9)]
        HRESULT get_Languages(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(10)]
        HRESULT get_NumeralSystem(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_NumeralSystem(HSTRING value);

        [VtblIndex(12)]
        HRESULT GetCalendarSystem(HSTRING* value);

        [VtblIndex(13)]
        HRESULT ChangeCalendarSystem(HSTRING value);

        [VtblIndex(14)]
        HRESULT GetClock(HSTRING* value);

        [VtblIndex(15)]
        HRESULT ChangeClock(HSTRING value);

        [VtblIndex(16)]
        HRESULT GetDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* result
        );

        [VtblIndex(17)]
        HRESULT SetDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
        );

        [VtblIndex(18)]
        HRESULT SetToNow();

        [VtblIndex(19)]
        HRESULT get_FirstEra([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT get_LastEra([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT get_NumberOfEras([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(22)]
        HRESULT get_Era([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(23)]
        HRESULT put_Era([NativeTypeName("INT32")] int value);

        [VtblIndex(24)]
        HRESULT AddEras([NativeTypeName("INT32")] int eras);

        [VtblIndex(25)]
        HRESULT EraAsFullString(HSTRING* result);

        [VtblIndex(26)]
        HRESULT EraAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result);

        [VtblIndex(27)]
        HRESULT get_FirstYearInThisEra([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(28)]
        HRESULT get_LastYearInThisEra([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(29)]
        HRESULT get_NumberOfYearsInThisEra([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(30)]
        HRESULT get_Year([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(31)]
        HRESULT put_Year([NativeTypeName("INT32")] int value);

        [VtblIndex(32)]
        HRESULT AddYears([NativeTypeName("INT32")] int years);

        [VtblIndex(33)]
        HRESULT YearAsString(HSTRING* result);

        [VtblIndex(34)]
        HRESULT YearAsTruncatedString(
            [NativeTypeName("INT32")] int remainingDigits,
            HSTRING* result
        );

        [VtblIndex(35)]
        HRESULT YearAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result);

        [VtblIndex(36)]
        HRESULT get_FirstMonthInThisYear([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(37)]
        HRESULT get_LastMonthInThisYear([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(38)]
        HRESULT get_NumberOfMonthsInThisYear([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(39)]
        HRESULT get_Month([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(40)]
        HRESULT put_Month([NativeTypeName("INT32")] int value);

        [VtblIndex(41)]
        HRESULT AddMonths([NativeTypeName("INT32")] int months);

        [VtblIndex(42)]
        HRESULT MonthAsFullString(HSTRING* result);

        [VtblIndex(43)]
        HRESULT MonthAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result);

        [VtblIndex(44)]
        HRESULT MonthAsFullSoloString(HSTRING* result);

        [VtblIndex(45)]
        HRESULT MonthAsSoloString([NativeTypeName("INT32")] int idealLength, HSTRING* result);

        [VtblIndex(46)]
        HRESULT MonthAsNumericString(HSTRING* result);

        [VtblIndex(47)]
        HRESULT MonthAsPaddedNumericString(
            [NativeTypeName("INT32")] int minDigits,
            HSTRING* result
        );

        [VtblIndex(48)]
        HRESULT AddWeeks([NativeTypeName("INT32")] int weeks);

        [VtblIndex(49)]
        HRESULT get_FirstDayInThisMonth([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(50)]
        HRESULT get_LastDayInThisMonth([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(51)]
        HRESULT get_NumberOfDaysInThisMonth([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(52)]
        HRESULT get_Day([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(53)]
        HRESULT put_Day([NativeTypeName("INT32")] int value);

        [VtblIndex(54)]
        HRESULT AddDays([NativeTypeName("INT32")] int days);

        [VtblIndex(55)]
        HRESULT DayAsString(HSTRING* result);

        [VtblIndex(56)]
        HRESULT DayAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result);

        [VtblIndex(57)]
        HRESULT get_DayOfWeek(
            [NativeTypeName("ABI::Windows::Globalization::DayOfWeek *")] DayOfWeek* value
        );

        [VtblIndex(58)]
        HRESULT DayOfWeekAsFullString(HSTRING* result);

        [VtblIndex(59)]
        HRESULT DayOfWeekAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result);

        [VtblIndex(60)]
        HRESULT DayOfWeekAsFullSoloString(HSTRING* result);

        [VtblIndex(61)]
        HRESULT DayOfWeekAsSoloString([NativeTypeName("INT32")] int idealLength, HSTRING* result);

        [VtblIndex(62)]
        HRESULT get_FirstPeriodInThisDay([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(63)]
        HRESULT get_LastPeriodInThisDay([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(64)]
        HRESULT get_NumberOfPeriodsInThisDay([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(65)]
        HRESULT get_Period([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(66)]
        HRESULT put_Period([NativeTypeName("INT32")] int value);

        [VtblIndex(67)]
        HRESULT AddPeriods([NativeTypeName("INT32")] int periods);

        [VtblIndex(68)]
        HRESULT PeriodAsFullString(HSTRING* result);

        [VtblIndex(69)]
        HRESULT PeriodAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result);

        [VtblIndex(70)]
        HRESULT get_FirstHourInThisPeriod([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(71)]
        HRESULT get_LastHourInThisPeriod([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(72)]
        HRESULT get_NumberOfHoursInThisPeriod([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(73)]
        HRESULT get_Hour([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(74)]
        HRESULT put_Hour([NativeTypeName("INT32")] int value);

        [VtblIndex(75)]
        HRESULT AddHours([NativeTypeName("INT32")] int hours);

        [VtblIndex(76)]
        HRESULT HourAsString(HSTRING* result);

        [VtblIndex(77)]
        HRESULT HourAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result);

        [VtblIndex(78)]
        HRESULT get_Minute([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(79)]
        HRESULT put_Minute([NativeTypeName("INT32")] int value);

        [VtblIndex(80)]
        HRESULT AddMinutes([NativeTypeName("INT32")] int minutes);

        [VtblIndex(81)]
        HRESULT MinuteAsString(HSTRING* result);

        [VtblIndex(82)]
        HRESULT MinuteAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result);

        [VtblIndex(83)]
        HRESULT get_Second([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(84)]
        HRESULT put_Second([NativeTypeName("INT32")] int value);

        [VtblIndex(85)]
        HRESULT AddSeconds([NativeTypeName("INT32")] int seconds);

        [VtblIndex(86)]
        HRESULT SecondAsString(HSTRING* result);

        [VtblIndex(87)]
        HRESULT SecondAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result);

        [VtblIndex(88)]
        HRESULT get_Nanosecond([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(89)]
        HRESULT put_Nanosecond([NativeTypeName("INT32")] int value);

        [VtblIndex(90)]
        HRESULT AddNanoseconds([NativeTypeName("INT32")] int nanoseconds);

        [VtblIndex(91)]
        HRESULT NanosecondAsString(HSTRING* result);

        [VtblIndex(92)]
        HRESULT NanosecondAsPaddedString([NativeTypeName("INT32")] int minDigits, HSTRING* result);

        [VtblIndex(93)]
        HRESULT Compare(
            [NativeTypeName("ABI::Windows::Globalization::ICalendar *")] ICalendar other,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(94)]
        HRESULT CompareDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime other,
            [NativeTypeName("INT32 *")] int* result
        );

        [VtblIndex(95)]
        HRESULT CopyTo(
            [NativeTypeName("ABI::Windows::Globalization::ICalendar *")] ICalendar other
        );

        [VtblIndex(96)]
        HRESULT get_FirstMinuteInThisHour([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(97)]
        HRESULT get_LastMinuteInThisHour([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(98)]
        HRESULT get_NumberOfMinutesInThisHour([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(99)]
        HRESULT get_FirstSecondInThisMinute([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(100)]
        HRESULT get_LastSecondInThisMinute([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(101)]
        HRESULT get_NumberOfSecondsInThisMinute([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(102)]
        HRESULT get_ResolvedLanguage(HSTRING* value);

        [VtblIndex(103)]
        HRESULT get_IsDaylightSavingTime([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Globalization::ICalendar **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICalendar*, int> Clone;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetToMin;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetToMax;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> get_Languages;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_NumeralSystem;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_NumeralSystem;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetCalendarSystem;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ChangeCalendarSystem;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetClock;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ChangeClock;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> GetDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int> SetDateTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetToNow;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstEra;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastEra;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfEras;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Era;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Era;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddEras;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> EraAsFullString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> EraAsString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstYearInThisEra;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastYearInThisEra;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfYearsInThisEra;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Year;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Year;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddYears;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> YearAsString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> YearAsTruncatedString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> YearAsPaddedString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstMonthInThisYear;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastMonthInThisYear;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfMonthsInThisYear;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Month;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Month;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddMonths;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> MonthAsFullString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> MonthAsString;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> MonthAsFullSoloString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> MonthAsSoloString;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> MonthAsNumericString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> MonthAsPaddedNumericString;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddWeeks;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstDayInThisMonth;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastDayInThisMonth;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfDaysInThisMonth;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Day;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Day;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddDays;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> DayAsString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> DayAsPaddedString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Globalization::DayOfWeek *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DayOfWeek*, int> get_DayOfWeek;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> DayOfWeekAsFullString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> DayOfWeekAsString;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> DayOfWeekAsFullSoloString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> DayOfWeekAsSoloString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstPeriodInThisDay;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastPeriodInThisDay;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfPeriodsInThisDay;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Period;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Period;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddPeriods;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> PeriodAsFullString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> PeriodAsString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstHourInThisPeriod;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastHourInThisPeriod;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfHoursInThisPeriod;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Hour;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Hour;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddHours;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> HourAsString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> HourAsPaddedString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Minute;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Minute;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddMinutes;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> MinuteAsString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> MinuteAsPaddedString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Second;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Second;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddSeconds;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> SecondAsString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> SecondAsPaddedString;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Nanosecond;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Nanosecond;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddNanoseconds;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> NanosecondAsString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HSTRING*, int> NanosecondAsPaddedString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Globalization::ICalendar *, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICalendar, int*, int> Compare;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, INT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int*, int> CompareDateTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Globalization::ICalendar *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICalendar, int> CopyTo;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstMinuteInThisHour;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastMinuteInThisHour;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfMinutesInThisHour;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstSecondInThisMinute;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastSecondInThisMinute;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfSecondsInThisMinute;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ResolvedLanguage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDaylightSavingTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICalendar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICalendar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICalendar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICalendar(Silk.NET.WinRT.IInspectable value)
    {
        return new ICalendar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICalendar"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICalendar"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICalendar value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICalendar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICalendar(Silk.NET.Windows.IUnknown value)
    {
        return new ICalendar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICalendar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICalendar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICalendar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
