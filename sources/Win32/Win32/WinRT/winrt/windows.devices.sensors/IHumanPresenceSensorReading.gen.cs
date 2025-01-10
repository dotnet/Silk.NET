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

[Guid("83533BF5-A85A-5D50-8BE4-6072D745A3BB")]
[NativeTypeName("struct IHumanPresenceSensorReading : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorReading
    : IHumanPresenceSensorReading.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensorReading));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReading, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorReading, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorReading, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReading, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHumanPresenceSensorReading, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHumanPresenceSensorReading, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReading, WinRTDateTime*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Presence(
        [NativeTypeName("ABI::Windows::Devices::Sensors::HumanPresence *")] HumanPresence* value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReading, HumanPresence*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Engagement(
        [NativeTypeName("ABI::Windows::Devices::Sensors::HumanEngagement *")] HumanEngagement* value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReading, HumanEngagement*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReading, IReference<uint>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        HRESULT get_Presence(
            [NativeTypeName("ABI::Windows::Devices::Sensors::HumanPresence *")] HumanPresence* value
        );

        [VtblIndex(8)]
        HRESULT get_Engagement(
            [NativeTypeName("ABI::Windows::Devices::Sensors::HumanEngagement *")]
                HumanEngagement* value
        );

        [VtblIndex(9)]
        HRESULT get_DistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
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
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::HumanPresence *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HumanPresence*, int> get_Presence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::HumanEngagement *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HumanEngagement*, int> get_Engagement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_DistanceInMillimeters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHumanPresenceSensorReading"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHumanPresenceSensorReading(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHumanPresenceSensorReading"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensorReading(Silk.NET.WinRT.IInspectable value)
    {
        return new IHumanPresenceSensorReading(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensorReading"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensorReading"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHumanPresenceSensorReading value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHumanPresenceSensorReading"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensorReading(Silk.NET.Windows.IUnknown value)
    {
        return new IHumanPresenceSensorReading(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensorReading"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensorReading"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHumanPresenceSensorReading value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
