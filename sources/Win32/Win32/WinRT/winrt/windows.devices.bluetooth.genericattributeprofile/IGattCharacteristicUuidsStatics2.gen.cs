// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1855B425-D46E-4A2C-9C3F-ED6DEA29E7BE")]
[NativeTypeName("struct IGattCharacteristicUuidsStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristicUuidsStatics2
    : IGattCharacteristicUuidsStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattCharacteristicUuidsStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattCharacteristicUuidsStatics2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IGattCharacteristicUuidsStatics2, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattCharacteristicUuidsStatics2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlertCategoryId(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AlertCategoryIdBitMask(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AlertLevel(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AlertNotificationControlPoint(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AlertStatus(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_GapAppearance(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_BootKeyboardInputReport(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BootKeyboardOutputReport(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_BootMouseInputReport(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CurrentTime(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CyclingPowerControlPoint(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CyclingPowerFeature(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CyclingPowerMeasurement(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_CyclingPowerVector(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DateTime(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DayDateTime(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_DayOfWeek(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_GapDeviceName(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_DstOffset(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ExactTime256(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_FirmwareRevisionString(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_HardwareRevisionString(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_HidControlPoint(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_HidInformation(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Ieee1107320601RegulatoryCertificationDataList(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_LnControlPoint(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_LnFeature(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_LocalTimeInformation(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_LocationAndSpeed(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_ManufacturerNameString(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[35]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_ModelNumberString(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[36]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_Navigation(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[37]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_NewAlert(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[38]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_GapPeripheralPreferredConnectionParameters(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[39]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_GapPeripheralPrivacyFlag(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_PnpId(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[41]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_PositionQuality(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[42]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_ProtocolMode(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[43]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_GapReconnectionAddress(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[44]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_ReferenceTimeInformation(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[45]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_Report(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[46]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_ReportMap(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[47]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_RingerControlPoint(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[48]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_RingerSetting(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[49]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_ScanIntervalWindow(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[50]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_ScanRefresh(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[51]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_SerialNumberString(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[52]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_GattServiceChanged(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[53]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_SoftwareRevisionString(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[54]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_SupportedNewAlertCategory(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[55]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_SupportUnreadAlertCategory(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[56]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_SystemId(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[57]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_TimeAccuracy(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[58]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_TimeSource(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[59]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_TimeUpdateControlPoint(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[60]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_TimeUpdateState(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[61]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_TimeWithDst(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[62]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_TimeZone(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[63]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_TxPowerLevel(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[64]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_UnreadAlertStatus(Guid* value)
    {
        return ((delegate* unmanaged<IGattCharacteristicUuidsStatics2, Guid*, int>)((*lpVtbl)[65]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlertCategoryId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_AlertCategoryIdBitMask(Guid* value);

        [VtblIndex(8)]
        HRESULT get_AlertLevel(Guid* value);

        [VtblIndex(9)]
        HRESULT get_AlertNotificationControlPoint(Guid* value);

        [VtblIndex(10)]
        HRESULT get_AlertStatus(Guid* value);

        [VtblIndex(11)]
        HRESULT get_GapAppearance(Guid* value);

        [VtblIndex(12)]
        HRESULT get_BootKeyboardInputReport(Guid* value);

        [VtblIndex(13)]
        HRESULT get_BootKeyboardOutputReport(Guid* value);

        [VtblIndex(14)]
        HRESULT get_BootMouseInputReport(Guid* value);

        [VtblIndex(15)]
        HRESULT get_CurrentTime(Guid* value);

        [VtblIndex(16)]
        HRESULT get_CyclingPowerControlPoint(Guid* value);

        [VtblIndex(17)]
        HRESULT get_CyclingPowerFeature(Guid* value);

        [VtblIndex(18)]
        HRESULT get_CyclingPowerMeasurement(Guid* value);

        [VtblIndex(19)]
        HRESULT get_CyclingPowerVector(Guid* value);

        [VtblIndex(20)]
        HRESULT get_DateTime(Guid* value);

        [VtblIndex(21)]
        HRESULT get_DayDateTime(Guid* value);

        [VtblIndex(22)]
        HRESULT get_DayOfWeek(Guid* value);

        [VtblIndex(23)]
        HRESULT get_GapDeviceName(Guid* value);

        [VtblIndex(24)]
        HRESULT get_DstOffset(Guid* value);

        [VtblIndex(25)]
        HRESULT get_ExactTime256(Guid* value);

        [VtblIndex(26)]
        HRESULT get_FirmwareRevisionString(Guid* value);

        [VtblIndex(27)]
        HRESULT get_HardwareRevisionString(Guid* value);

        [VtblIndex(28)]
        HRESULT get_HidControlPoint(Guid* value);

        [VtblIndex(29)]
        HRESULT get_HidInformation(Guid* value);

        [VtblIndex(30)]
        HRESULT get_Ieee1107320601RegulatoryCertificationDataList(Guid* value);

        [VtblIndex(31)]
        HRESULT get_LnControlPoint(Guid* value);

        [VtblIndex(32)]
        HRESULT get_LnFeature(Guid* value);

        [VtblIndex(33)]
        HRESULT get_LocalTimeInformation(Guid* value);

        [VtblIndex(34)]
        HRESULT get_LocationAndSpeed(Guid* value);

        [VtblIndex(35)]
        HRESULT get_ManufacturerNameString(Guid* value);

        [VtblIndex(36)]
        HRESULT get_ModelNumberString(Guid* value);

        [VtblIndex(37)]
        HRESULT get_Navigation(Guid* value);

        [VtblIndex(38)]
        HRESULT get_NewAlert(Guid* value);

        [VtblIndex(39)]
        HRESULT get_GapPeripheralPreferredConnectionParameters(Guid* value);

        [VtblIndex(40)]
        HRESULT get_GapPeripheralPrivacyFlag(Guid* value);

        [VtblIndex(41)]
        HRESULT get_PnpId(Guid* value);

        [VtblIndex(42)]
        HRESULT get_PositionQuality(Guid* value);

        [VtblIndex(43)]
        HRESULT get_ProtocolMode(Guid* value);

        [VtblIndex(44)]
        HRESULT get_GapReconnectionAddress(Guid* value);

        [VtblIndex(45)]
        HRESULT get_ReferenceTimeInformation(Guid* value);

        [VtblIndex(46)]
        HRESULT get_Report(Guid* value);

        [VtblIndex(47)]
        HRESULT get_ReportMap(Guid* value);

        [VtblIndex(48)]
        HRESULT get_RingerControlPoint(Guid* value);

        [VtblIndex(49)]
        HRESULT get_RingerSetting(Guid* value);

        [VtblIndex(50)]
        HRESULT get_ScanIntervalWindow(Guid* value);

        [VtblIndex(51)]
        HRESULT get_ScanRefresh(Guid* value);

        [VtblIndex(52)]
        HRESULT get_SerialNumberString(Guid* value);

        [VtblIndex(53)]
        HRESULT get_GattServiceChanged(Guid* value);

        [VtblIndex(54)]
        HRESULT get_SoftwareRevisionString(Guid* value);

        [VtblIndex(55)]
        HRESULT get_SupportedNewAlertCategory(Guid* value);

        [VtblIndex(56)]
        HRESULT get_SupportUnreadAlertCategory(Guid* value);

        [VtblIndex(57)]
        HRESULT get_SystemId(Guid* value);

        [VtblIndex(58)]
        HRESULT get_TimeAccuracy(Guid* value);

        [VtblIndex(59)]
        HRESULT get_TimeSource(Guid* value);

        [VtblIndex(60)]
        HRESULT get_TimeUpdateControlPoint(Guid* value);

        [VtblIndex(61)]
        HRESULT get_TimeUpdateState(Guid* value);

        [VtblIndex(62)]
        HRESULT get_TimeWithDst(Guid* value);

        [VtblIndex(63)]
        HRESULT get_TimeZone(Guid* value);

        [VtblIndex(64)]
        HRESULT get_TxPowerLevel(Guid* value);

        [VtblIndex(65)]
        HRESULT get_UnreadAlertStatus(Guid* value);
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
        public delegate* unmanaged<TSelf*, Guid*, int> get_AlertCategoryId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_AlertCategoryIdBitMask;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_AlertLevel;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_AlertNotificationControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_AlertStatus;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_GapAppearance;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_BootKeyboardInputReport;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_BootKeyboardOutputReport;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_BootMouseInputReport;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_CurrentTime;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_CyclingPowerControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_CyclingPowerFeature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_CyclingPowerMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_CyclingPowerVector;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_DateTime;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_DayDateTime;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_DayOfWeek;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_GapDeviceName;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_DstOffset;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ExactTime256;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_FirmwareRevisionString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_HardwareRevisionString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_HidControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_HidInformation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            int> get_Ieee1107320601RegulatoryCertificationDataList;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_LnControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_LnFeature;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_LocalTimeInformation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_LocationAndSpeed;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ManufacturerNameString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ModelNumberString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Navigation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_NewAlert;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            int> get_GapPeripheralPreferredConnectionParameters;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_GapPeripheralPrivacyFlag;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_PnpId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_PositionQuality;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ProtocolMode;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_GapReconnectionAddress;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ReferenceTimeInformation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Report;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ReportMap;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_RingerControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_RingerSetting;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ScanIntervalWindow;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ScanRefresh;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_SerialNumberString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_GattServiceChanged;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_SoftwareRevisionString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_SupportedNewAlertCategory;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_SupportUnreadAlertCategory;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_SystemId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TimeAccuracy;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TimeSource;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TimeUpdateControlPoint;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TimeUpdateState;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TimeWithDst;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TimeZone;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TxPowerLevel;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_UnreadAlertStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattCharacteristicUuidsStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattCharacteristicUuidsStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattCharacteristicUuidsStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattCharacteristicUuidsStatics2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IGattCharacteristicUuidsStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattCharacteristicUuidsStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattCharacteristicUuidsStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IGattCharacteristicUuidsStatics2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattCharacteristicUuidsStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattCharacteristicUuidsStatics2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IGattCharacteristicUuidsStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattCharacteristicUuidsStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattCharacteristicUuidsStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IGattCharacteristicUuidsStatics2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
