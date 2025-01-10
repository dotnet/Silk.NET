// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("79F5C6BB-CE0E-4133-B47E-8627EA72F677")]
[NativeTypeName("struct IPedometerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPedometerStatics2 : IPedometerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPedometerStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPedometerStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPedometerStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPedometerStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPedometerStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPedometerStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPedometerStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetReadingsFromTriggerDetails(
        [NativeTypeName("ABI::Windows::Devices::Sensors::ISensorDataThresholdTriggerDetails *")]
            ISensorDataThresholdTriggerDetails triggerDetails,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CPedometerReading_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IPedometerStatics2,
                ISensorDataThresholdTriggerDetails,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, triggerDetails, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetReadingsFromTriggerDetails(
            [NativeTypeName("ABI::Windows::Devices::Sensors::ISensorDataThresholdTriggerDetails *")]
                ISensorDataThresholdTriggerDetails triggerDetails,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CPedometerReading_t **"
            )]
                IVectorView<IntPtr>** result
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
            "HRESULT (ABI::Windows::Devices::Sensors::ISensorDataThresholdTriggerDetails *, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CPedometerReading_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISensorDataThresholdTriggerDetails,
            IVectorView<IntPtr>**,
            int> GetReadingsFromTriggerDetails;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPedometerStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPedometerStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPedometerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPedometerStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IPedometerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPedometerStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPedometerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPedometerStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPedometerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPedometerStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IPedometerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPedometerStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPedometerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPedometerStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
