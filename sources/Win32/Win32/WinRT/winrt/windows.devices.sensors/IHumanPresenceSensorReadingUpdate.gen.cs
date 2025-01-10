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

[Guid("42419C77-6D2F-55A0-9E01-C9CBE7B2D6DF")]
[NativeTypeName("struct IHumanPresenceSensorReadingUpdate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorReadingUpdate
    : IHumanPresenceSensorReadingUpdate.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensorReadingUpdate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorReadingUpdate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorReadingUpdate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, IReference<DateTime>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Timestamp(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, IReference<DateTime>*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Presence(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t **"
        )]
            IReference<HumanPresence>** value
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSensorReadingUpdate,
                IReference<HumanPresence>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Presence(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t *"
        )]
            IReference<HumanPresence>* value
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSensorReadingUpdate,
                IReference<HumanPresence>*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Engagement(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t **"
        )]
            IReference<HumanEngagement>** value
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSensorReadingUpdate,
                IReference<HumanEngagement>**,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Engagement(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t *"
        )]
            IReference<HumanEngagement>* value
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSensorReadingUpdate,
                IReference<HumanEngagement>*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, IReference<uint>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DistanceInMillimeters(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* value
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorReadingUpdate, IReference<uint>*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(7)]
        HRESULT put_Timestamp(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(8)]
        HRESULT get_Presence(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t **"
            )]
                IReference<HumanPresence>** value
        );

        [VtblIndex(9)]
        HRESULT put_Presence(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t *"
            )]
                IReference<HumanPresence>* value
        );

        [VtblIndex(10)]
        HRESULT get_Engagement(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t **"
            )]
                IReference<HumanEngagement>** value
        );

        [VtblIndex(11)]
        HRESULT put_Engagement(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t *"
            )]
                IReference<HumanEngagement>* value
        );

        [VtblIndex(12)]
        HRESULT get_DistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(13)]
        HRESULT put_DistanceInMillimeters(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* value
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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_Timestamp;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_Timestamp;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<HumanPresence>**, int> get_Presence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<HumanPresence>*, int> put_Presence;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<HumanEngagement>**, int> get_Engagement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<HumanEngagement>*, int> put_Engagement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_DistanceInMillimeters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>*, int> put_DistanceInMillimeters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHumanPresenceSensorReadingUpdate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHumanPresenceSensorReadingUpdate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHumanPresenceSensorReadingUpdate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensorReadingUpdate(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHumanPresenceSensorReadingUpdate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensorReadingUpdate"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensorReadingUpdate"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHumanPresenceSensorReadingUpdate value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHumanPresenceSensorReadingUpdate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensorReadingUpdate(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHumanPresenceSensorReadingUpdate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensorReadingUpdate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensorReadingUpdate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHumanPresenceSensorReadingUpdate value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
